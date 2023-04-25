using Microsoft.VisualStudio;
using System;
using System.Windows.Controls;
using swimSuitShop2;
using System.Windows;
using NUnit.Framework;
using swimSuitShop2.View;

namespace LingerieTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var window = new AdminPanel();

            var userNameTextBox = (TextBox)window.FindName("");
        }
    }
}