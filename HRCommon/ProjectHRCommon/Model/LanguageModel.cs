using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class LanguageModel
    {
        private readonly int _id;
        private readonly string _code;
        private readonly string _description;

        public LanguageModel(int id, string code, string description)
        {
            _id = id;
            _code = code;
            _description = description;
        }

        public int Id => _id;

        public string Code => _code;

        public string Description => _description;
    }
}
