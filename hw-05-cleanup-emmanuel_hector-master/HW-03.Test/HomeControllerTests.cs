
using HW_03.Controllers;
using HW_03.Models;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace HW_03.Test
{
    public class HomeControllerTests
    {
        private HomeController homeController;
        private Mock<ILogger<HomeController>> mockLogger;

        [SetUp]
        public void Setup()
        {
            mockLogger = new Mock<ILogger<HomeController>>();
            //homeController = new HomeController(mockLogger.Object, new PostgresRepository());
        }

        [Test]
        public async Task NewPostAddsPostToRepo()
        {
            Post newPost = new Post();
            await homeController.NewPost(newPost);
            //var count = homeController.Repository.PostList.Count();
            //Assert.AreEqual(count, 1);
        }

        [Test]
        public async Task EditPostUpdatesEditedOn()
        {
            Post newPost = new Post()
            {
                Title = "Title",
                Body = "Body",
                ID = 0
            };
            await homeController.NewPost(newPost);
            Assert.IsNull(newPost.EditedOn);

            await homeController.Edit(newPost);

            Assert.IsNotNull(newPost.EditedOn);
        }
    }
}