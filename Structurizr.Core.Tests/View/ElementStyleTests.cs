﻿using System;
using Xunit;

namespace Structurizr.Core.Tests
{
    
    public class ElementStyleTests
    {

        [Fact]
        public void Test_Opacity()
        {
            ElementStyle style = new ElementStyle();
            Assert.Null(style.Opacity);

            style.Opacity = -1;
            Assert.Equal(0, style.Opacity);

            style.Opacity = 0;
            Assert.Equal(0, style.Opacity);

            style.Opacity = 50;
            Assert.Equal(50, style.Opacity);

            style.Opacity = 100;
            Assert.Equal(100, style.Opacity);

            style.Opacity = 101;
            Assert.Equal(100, style.Opacity);
        }

        [Fact]
        public void Test_Background_SetsTheBackgroundProperty_WhenAValidHexColorCodeIsSpecified()
        {
            ElementStyle style = new ElementStyle();
            style.Background = "#ffffff";
            Assert.Equal("#ffffff", style.Background);

            style.Background = "#FFFFFF";
            Assert.Equal("#ffffff", style.Background);

            style.Background = "#123456";
            Assert.Equal("#123456", style.Background);
        }

        [Fact]
        public void Test_Background_ThrowsAnException_WhenAnInvalidHexColorCodeIsSpecified()
        {
            try
            {
                ElementStyle style = new ElementStyle();
                style.Background = "white";
                throw new TestFailedException();
            }
            catch (ArgumentException ae)
            {
                Assert.Equal("'white' is not a valid hex color code.", ae.Message);
            }
        }

        [Fact]
        public void Test_Color_SetsTheColorProperty_WhenAValidHexColorCodeIsSpecified()
        {
            ElementStyle style = new ElementStyle();
            style.Color = "#ffffff";
            Assert.Equal("#ffffff", style.Color);

            style.Color = "#FFFFFF";
            Assert.Equal("#ffffff", style.Color);

            style.Color = "#123456";
            Assert.Equal("#123456", style.Color);
        }

        [Fact]
        public void Test_Color_ThrowsAnException_WhenAnInvalidHexColorCodeIsSpecified()
        {
            try
            {
                ElementStyle style = new ElementStyle();
                style.Color = "white";
                throw new TestFailedException();
            }
            catch (ArgumentException ae)
            {
                Assert.Equal("'white' is not a valid hex color code.", ae.Message);
            }
        }

    }
}
