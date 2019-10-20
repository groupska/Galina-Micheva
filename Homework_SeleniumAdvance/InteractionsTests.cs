using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Homework_SeleniumAdvance
{
    [TestFixture]
    class InteractionsTests
    {
        private ChromeDriver _driver;
        public object SelectElement { get; private set; }

        [SetUp]

        public void ClassInit()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();
            
        }

        [Test]

        public void ResizeTest2()
        {
            _driver.Url = "http://demoqa.com/resizable/";

            var box = _driver.FindElement(By.Id("resizable"));
            var expectedWidth = box.Size.Width - 67;
            var expectedHeight = box.Size.Height - 67;

            var resize = _driver.FindElement(By.XPath("//*[@id='resizable']/div[3]"));

            var builder = new Actions(_driver);
            builder.DragAndDropToOffset(resize, -50, -50).Perform();

            double actualWidth = box.Size.Width;
            double actualHeight = box.Size.Height;

            Assert.AreEqual(expectedWidth, actualWidth, 2);
            Assert.AreEqual(expectedHeight, actualHeight, 2);
        }

        [Test]

        public void ResizeTest1()
        {
            _driver.Url = "http://demoqa.com/resizable/";

            var box = _driver.FindElement(By.Id("resizable"));
            var expectedWidth = box.Size.Width + 33;
            var expectedHeight = box.Size.Height + 33;

            var resize = _driver.FindElement(By.XPath("//*[@id='resizable']/div[3]"));

            var builder = new Actions(_driver);
            builder.DragAndDropToOffset(resize, 50, 50).Perform();

            double actualWidth = box.Size.Width;
            double actualHeight = box.Size.Height;

            Assert.AreEqual(expectedWidth, actualWidth, 2);
            Assert.AreEqual(expectedHeight, actualHeight, 2);
        }

        [Test]

        public void SelectableTest1()
        {
            _driver.Url = "https://demoqa.com/selectable/";

            var box = _driver.FindElement(By.XPath("//*[@id='selectable']/li[1]"));

            box.Click();

            string expectBoxClass = "ui-widget-content ui-selectee ui-selected";
            var actualBoxClass = box.GetAttribute("class");

            Assert.AreEqual(expectBoxClass, actualBoxClass);


        }

        [Test]

        public void SelectableTest2()
        {
            _driver.Url = "https://demoqa.com/selectable/";
            
            //*[@id="selectable"]/li[1]
            var box = _driver.FindElement(By.XPath("//*[@id='selectable']/li[1]"));

            box.Click();
            
            var actualColor = box.GetCssValue("color");

            var expectedColor = "rgba(255, 255, 255, 1)";

            Assert.AreEqual(expectedColor, actualColor);


        }

        [Test]

        public void DroppableTest1()
        {
            _driver.Url = "https://demoqa.com/droppable/";

            var box = _driver.FindElement(By.Id("draggable"));
            var boxText = _driver.FindElement(By.XPath("//*[@id='droppable']/p"));
            
            string expectedBoxText = "Dropped!";

            var builder = new Actions(_driver);
            builder.DragAndDropToOffset(box, 130, 20).Perform();

            var actualBoxText = boxText.Text;

            Assert.AreEqual(expectedBoxText, actualBoxText);
            
        }

        [Test]

        public void DropabbleTest2()
        {
            _driver.Url = "https://demoqa.com/droppable/";

            var box = _driver.FindElement(By.Id("draggable"));
            var boxText = _driver.FindElement(By.XPath("//*[@id='droppable']/p"));

            var builder = new Actions(_driver);
            builder.DragAndDropToOffset(box, 130, 20).Perform();

            string expectBoxClass = "ui-widget-content ui-draggable ui-draggable-handle";
            var actualBoxClass = box.GetAttribute("class");

            Assert.AreEqual(expectBoxClass, actualBoxClass);


        }

        [Test]

        public void DroppableTest3()
        {
            _driver.Url = "https://demoqa.com/droppable/";

            var box = _driver.FindElement(By.Id("draggable"));
            var boxText = _driver.FindElement(By.XPath("//*[@id='droppable']/p"));

            

            var builder = new Actions(_driver);
            builder.DragAndDropToOffset(box, 10, 10).Perform();

            var actualBoxText = boxText.Text;
            string expectedBoxText = "Drop here";

            Assert.AreEqual(expectedBoxText, actualBoxText);

        }

        [Test]

        public void DroppableTest4()
        {
            _driver.Url = "https://demoqa.com/droppable/";

            var dragable = _driver.FindElement(By.Id("draggable"));
            var target = _driver.FindElement(By.Id("droppable"));

            var dragX = dragable.Location.X;
            var dragY = dragable.Location.Y;

            var targetColor = target.GetCssValue("color");


            var builder = new Actions(_driver);
            builder.DragAndDrop(dragable, target).Perform();

            var afterX = dragable.Location.X;
            var afterY = dragable.Location.Y;

            var afterColor = target.GetCssValue("style");

           // Assert.AreEqual(expectedBoxText, actualBoxText);

        }

        [Test]

        public void DroppableTest5()
        {
            _driver.Url = "https://demoqa.com/droppable/";

            var dragable = _driver.FindElement(By.Id("draggable"));
            var target = _driver.FindElement(By.Id("droppable"));

            var builder = new Actions(_driver);
            builder.DragAndDrop(dragable, target).Perform();

            var afterX = dragable.Location.X;
            var afterY = dragable.Location.Y;

            var targetX = 632;
            var targetY = 354;

             Assert.AreEqual(targetX, afterX, 2);
             Assert.AreEqual(targetY, afterY, 2);

        }
        [Test]

        public void SortableTest1()
        {
            _driver.Url = "https://demoqa.com/sortable/";

            var box = _driver.FindElement(By.XPath("//*[@id='sortable']/li[1]"));
            //var boxText = _driver.FindElement(By.XPath("//*[@id='droppable']/p"));
            
            var builder = new Actions(_driver);
            builder.DragAndDropToOffset(box, 0, 40).Perform();

           
            var firstPositionBox = _driver.FindElement(By.XPath("//*[@id='sortable']/li[1]"));

            var actualBoxText = firstPositionBox.Text;
            string expectedBoxText = "Item 2";

            Assert.AreEqual(expectedBoxText, actualBoxText);

        }

        [Test]

        public void SortableTest2()
        {
            _driver.Url = "https://demoqa.com/sortable/";

            var boxItem1 = _driver.FindElement(By.XPath("//*[@id='sortable']/li[1]"));
            var boxTargetItem2 = _driver.FindElement(By.XPath("//*[@id='sortable']/li[2]"));

            var builder = new Actions(_driver);
            builder.DragAndDrop(boxItem1,boxTargetItem2).Perform();

            ////*[@id="sortable"]/li[1]
            var firstPositionBox = _driver.FindElement(By.XPath("//*[@id='sortable']/li[2]")).Text;
            var secondPositionBox = _driver.FindElement(By.XPath("//*[@id='sortable']/li[1]")).Text;
            
            var expectFirstBox = "Item 2";
            var expectSecondBox = "Item 1";

            Assert.AreEqual(expectFirstBox, firstPositionBox);
            Assert.AreEqual(expectSecondBox, secondPositionBox);

        }

        [Test]

        public void DraggableTest1()
        {
            _driver.Url = "https://demoqa.com/draggable/";

            var dragable = _driver.FindElement(By.Id("draggable"));
            
            var expectDragX = dragable.Location.X + 100;
            var expectDragY = dragable.Location.Y + 100;

            var builder = new Actions(_driver);
            builder.DragAndDropToOffset(dragable, + 100, + 100).Perform();

            var afterX = dragable.Location.X;
            var afterY = dragable.Location.Y;

            Assert.AreEqual(expectDragX, afterX, 2);
            Assert.AreEqual(expectDragY, afterY, 2);

        }

        [TearDown]

        public void TearDown()
        {
            _driver.Quit();
        }

        private void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }
}