﻿using Portfolio.Controls;
using Portfolio.Models.StartPage;
using Portfolio.Services.Repository;
using Portfolio_UnitTests.Mock;

namespace Portfolio_UnitTests.Areas.Base.Controls
{
    public class HomeTest
    {
        private readonly HomeController controller;

        private readonly Mock<IMessageRepository> repositoryMock;
        private readonly Mock<ILogger<HomeController>> logerMock;

        public HomeTest()
        {
            repositoryMock = new();
            logerMock = new();
            controller = new(logerMock.Object);

            controller.ControllerContext.HttpContext = HttpContextMock.Get();
        }

        [Fact]
        public void IndexGetReturnView()
        {
            var res = controller.Index() as ViewResult;

            Assert.NotNull(res);
        }

        [Fact]
        public void IndexPostAddMesage()
        {
            MessageModel message = new();

            var res = controller.Index(message, repositoryMock.Object) as ViewResult;

            Assert.NotNull(res);

            repositoryMock.Verify(c => c.Add(message));
        }

    }
}
