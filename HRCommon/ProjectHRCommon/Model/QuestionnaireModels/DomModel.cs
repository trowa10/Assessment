using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class DomModel
    {
        private readonly int _domId;
        private readonly string _elementName;
        private readonly string _style;
        private readonly string _group;
        private readonly bool _isRequired;
        private readonly string _placeHolder;
        private readonly string _value;
        private readonly bool _forAnswer;
        private readonly int _tableRow;
        private readonly double _order;
        private readonly string _text;

        public DomModel(int domId, string elementName, string style, string group, bool isRequired, string placeHolder, string value, bool forAnswer, int tableRow, double order, string text)
        {
            _domId = domId;
            _elementName = elementName;
            _style = style;
            _group = group;
            _isRequired = isRequired;
            _placeHolder = placeHolder;
            _value = value;
            _forAnswer = forAnswer;
            _tableRow = tableRow;
            _order = order;
            _text = text;
        }

        public int DomId => _domId;

        public string ElementName => _elementName;

        public string Style => _style;

        public string Group => _group;

        public bool IsRequired => _isRequired;

        public string PlaceHolder => _placeHolder;

        public string Value => _value;

        public bool ForAnswer => _forAnswer;

        public int TableRow => _tableRow;

        public double Order => _order;

        public string Text => _text;
    }
}
