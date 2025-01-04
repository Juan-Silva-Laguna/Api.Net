using Socialmedia.core.QueryFilters;
using System;

namespace Socialmedia.Infrastructure.Interfaces
{
    public interface IUriService
    {
        Uri GetPostPaginationUri(PostQueryFilter filter, string actionUrl);
    }
}