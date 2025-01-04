using Socialmedia.core.QueryFilters;
using Socialmedia.Infrastructure.Interfaces;
using System;

namespace SocialMedia.infraestructure.Services
{
    public class UriService : IUriService
    {
        private readonly string _bseUri;
        public UriService(string baseUri)
        {
            _bseUri = baseUri;
        }

        public Uri GetPostPaginationUri(PostQueryFilter filter, string actionUrl)
        {
            string baseUrl = $"{_bseUri}{actionUrl}";
            return new Uri(baseUrl);

        }
    }
}
