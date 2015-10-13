using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace kata.specs
{
    class when_recieving_different_number
    {
        Establish context = () =>
        {
            _stringCalculator = new StringCalculator();
        };
        private Because of = () =>
        {
            _result = _stringCalculator.Add("3");
        };

        private It should_return_3 = () =>
        {
            _result.ShouldBeLike(3);
        };

        private static StringCalculator _stringCalculator;
        private static int _result;
    }
}
