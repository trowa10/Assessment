using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class DataModel<T>
    {
        private readonly IReadOnlyCollection<T> _list;
        private readonly int _page;
        private readonly int _limit;
        private readonly int _totalPages;
        private readonly int _totalCount;

        public DataModel(IReadOnlyCollection<T> list, int page, int limit, int totalPages, int totalCount)
        {
            _list = list;
            _page = page;
            _limit = limit;
            _totalPages = totalPages;
            _totalCount = totalCount;
        }

        [JsonProperty("list")]
        public IReadOnlyCollection<T> List => _list;
        [JsonProperty("page")]
        public int Page => _page;
        [JsonProperty("limit")]
        public int Limit => _limit;
        [JsonProperty("totalPages")]
        public int TotalPages => _totalPages;
        [JsonProperty("totalCount")]
        public int TotalCount => _totalCount;
    }
}
