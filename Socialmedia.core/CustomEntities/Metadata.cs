﻿namespace Socialmedia.core.CustomEntities
{
    public class Metadata
    {
        public int TotalCount {  get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public bool HasPreviusPage { get; set; }
        public bool HasNextPage { get; set; }
        public string NextPageUrl { get; set; }
        public string PreviousPageUrl { get; set; }
    }
}
