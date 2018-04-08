﻿using FluentAutomation.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace FluentAutomation.Tests.Base
{
    // Not public because we don't want this test running in the standard suite and we aren't using Traits yet
    // to group them. Maybe later.
    public class MultiBrowserTests : FluentTest
    {

        [Fact(Skip = "manual for now until I ensure I can test everything on Appveyor")]
        /// See https://github.com/stirno/FluentAutomation/issues/104
        public void AssertShouldFailTest()
        {
            FluentAutomation.SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Chrome, SeleniumWebDriver.Browser.Firefox);

            Assert.Throws<FluentException>(() =>
            {
                I.Open("http://google.com/")
                 .Assert
                    .Class("wowza").On("input[type='text']");
            });
        }
    }
}
