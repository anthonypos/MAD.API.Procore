﻿using MAD.API.Procore.Requests;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MAD.API.Procore
{
    public class DefaultProcoreApiClientFactory
    {
        private Uri GetBaseAddress(bool isSandbox)
        {
            if (isSandbox)
                return new Uri("https://sandbox.procore.com/vapid/");
            else
                throw new NotImplementedException();
        }

        public ProcoreApiClient Create(ProcoreApiClientOptions options)
        {
            HttpClient httpClient = new HttpClient(new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate | DecompressionMethods.None,
            })
            {
                BaseAddress = this.GetBaseAddress(options.IsSandbox)
            };

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", options.AccessToken);

            return new ProcoreApiClient(
                httpClient: httpClient,
                options: options,
                querySegmentFactory: new ProcoreRequestUriQuerySegmentFactory());
        }
    }
}
