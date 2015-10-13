using Machine.Specifications;

namespace kata.specs
{
    class when_recibing_one_number
    {
        Establish context = () =>
        {
            _stringCalculator = new StringCalculator();
        };
        private Because of = () =>
        {
            _result = _stringCalculator.Add("1");
        };

        private It should_return_1 = () =>
        {
            _result.ShouldBeLike(1);
        };

        private static StringCalculator _stringCalculator;
        private static int _result;
    }
}
