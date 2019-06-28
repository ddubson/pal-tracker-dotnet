using System;
using Microsoft.AspNetCore.Mvc;
using Moq;
using PalTracker;
using Xunit;

namespace PalTrackerTests
{
    public class TimeEntryControllerTest
    {
        private readonly TimeEntryController _controller;
        private readonly Mock<ITimeEntryRepository> _repository;

        public TimeEntryControllerTest()
        {
            _repository = new Mock<ITimeEntryRepository>();
            _controller = new TimeEntryController(_repository.Object);
        }

        [Fact]
        public void Read()
        {
            var expected = new TimeEntry(1, 222, 333, new DateTime(2008, 08, 01, 12, 00, 01), 24);
            _repository.Setup(r => r.Contains(1)).Returns(true);
            _repository.Setup(r => r.Find(1)).Returns(expected);

            var response = _controller.Read(1);
            Assert.IsType<OkObjectResult>(response);
            var typedResponse = response as OkObjectResult;
            
            Assert.Equal(expected, typedResponse?.Value);
            Assert.Equal(200, typedResponse?.StatusCode);
        }

        [Fact]
        public void Read_NotFound()
        {
            _repository.Setup(r => r.Contains(1)).Returns(false);

            var response = _controller.Read(1);

            Assert.IsType<NotFoundResult>(response);

            var typedResponse = response as NotFoundResult;
            
            Assert.Equal(404, typedResponse?.StatusCode);
        }
    }
}