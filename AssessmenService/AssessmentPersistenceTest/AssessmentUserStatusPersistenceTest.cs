using AssessmentPersistence;
using AssessmentPersistence.Entities;
using MockQueryable.Moq;
using Moq;
using NUnit.Framework;
using ProjectHRCommon.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AssessmentPersistenceTest
{
    public class AssessmentUserStatusPersistenceTest
    {
        private Mock<DataContext> _mockDataContext;

        [SetUp]
        public void Setup()
        {
            _mockDataContext = new Mock<DataContext>();
        }

        //GetAll Method

        [Test]
        public void GetAll_CheckValidAssessmentTemplateId_ShouldReturnTrue()
        {
            //Arranage
            var userStatuses = new List<AssessmentUserStatus> {
                 new AssessmentUserStatus
                {
                     Id = 1,
                     AssessmentTemplateId = 1,
                     UserId = 10146063,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                }, new AssessmentUserStatus
                 {
                     Id = 2,
                     AssessmentTemplateId = 1,
                     UserId = 20000000,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                },

            };

            var mockUserData = userStatuses.AsQueryable().BuildMockDbSet();

            _mockDataContext.Setup(c => c.AssessmentUserStatus)
                .Returns(mockUserData.Object);

            //Act
            var assessmentUserStatusPersistence = new AssessmentUserStatusPersistence(_mockDataContext.Object);
            var actual = assessmentUserStatusPersistence.GetByAssessmentId(1).Result.Any();

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void GetAll_CheckInvalidAssessmentTemplateId_ShouldReturnFalse()
        {
            //Arranage
            var userStatuses = new List<AssessmentUserStatus> {
                 new AssessmentUserStatus
                {
                     Id = 1,
                     AssessmentTemplateId = 1,
                     UserId = 10146063,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                }, new AssessmentUserStatus
                 {
                     Id = 2,
                     AssessmentTemplateId = 1,
                     UserId = 20000000,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                },

            };

            var mockUserData = userStatuses.AsQueryable().BuildMockDbSet();

            _mockDataContext.Setup(c => c.AssessmentUserStatus)
                .Returns(mockUserData.Object);

            //Act
            var assessmentUserStatusPersistence = new AssessmentUserStatusPersistence(_mockDataContext.Object);
            var actual = assessmentUserStatusPersistence.GetByAssessmentId(9999).Result.Any();

            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void GetAll_CheckCorrectResponse_ShouldReturnTrue()
        {
            //Arranage
            var userStatuses = new List<AssessmentUserStatus> {
                 new AssessmentUserStatus
                {
                     Id = 1,
                     AssessmentTemplateId = 1,
                     UserId = 10146063,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                }

            };

            var mockUserData = userStatuses.AsQueryable().BuildMockDbSet();

            _mockDataContext.Setup(c => c.AssessmentUserStatus)
                .Returns(mockUserData.Object);

            //Act
            var assessmentUserStatusPersistence = new AssessmentUserStatusPersistence(_mockDataContext.Object);
            var actual = assessmentUserStatusPersistence.GetByAssessmentId(1).Result;

            //Assert
            Assert.IsTrue(actual.Select(x => x.Id).First() == 1);
            Assert.IsTrue(actual.Select(x => x.UserId).First() == 10146063);
            Assert.IsTrue(actual.Select(x => x.StatusId).First() == 0);
            Assert.IsTrue(((AssessmentState)actual.Select(x => x.StatusId).First()).ToString() == "New");
            Assert.IsTrue(actual.Select(x => x.EmployeeLevelId).First() == 1);
            Assert.IsTrue(((EmployeeLevel)actual.Select(x => x.EmployeeLevelId).First()).ToString() == "Developer");
            Assert.IsTrue(actual.Select(x => x.UserRegionId).First() == 1);
        }


        //GetByManagerUserId Method
        [Test]
        public void GetByManagerUserId_CheckValidAssessmentTemplateId_ShouldReturnTrue()
        {
            //Arranage
            var userStatuses = new List<AssessmentUserStatus> {
                 new AssessmentUserStatus
                {
                     Id = 1,
                     AssessmentTemplateId = 1,
                     UserId = 10146063,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                }, new AssessmentUserStatus
                 {
                     Id = 2,
                     AssessmentTemplateId = 1,
                     UserId = 20000001,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                },

            };

            var mockUserData = userStatuses.AsQueryable().BuildMockDbSet();

            _mockDataContext.Setup(c => c.AssessmentUserStatus)
                .Returns(mockUserData.Object);

            //Act
            var assessmentUserStatusPersistence = new AssessmentUserStatusPersistence(_mockDataContext.Object);
            var actual = assessmentUserStatusPersistence.GetByManagerUserId(1, 20000000).Result.Any();

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void GetByManagerUserId_CheckInvalidAssessmentTemplateId_ShouldReturnFalse()
        {
            //Arranage
            var userStatuses = new List<AssessmentUserStatus> {
                 new AssessmentUserStatus
                {
                     Id = 1,
                     AssessmentTemplateId = 1,
                     UserId = 10146063,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                }, new AssessmentUserStatus
                 {
                     Id = 2,
                     AssessmentTemplateId = 1,
                     UserId = 20000001,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                },

            };

            var mockUserData = userStatuses.AsQueryable().BuildMockDbSet();

            _mockDataContext.Setup(c => c.AssessmentUserStatus)
                .Returns(mockUserData.Object);

            //Act
            var assessmentUserStatusPersistence = new AssessmentUserStatusPersistence(_mockDataContext.Object);
            var actual = assessmentUserStatusPersistence.GetByManagerUserId(99, 20000000).Result.Any();

            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void GetByManagerUserId_CheckValidManagerIdButInvalidAssessmentTemplateId_ShouldReturnZeroCount()
        {
            //Arranage
            var userStatuses = new List<AssessmentUserStatus> {
                 new AssessmentUserStatus
                {
                     Id = 1,
                     AssessmentTemplateId = 1,
                     UserId = 10146063,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                }, new AssessmentUserStatus
                 {
                     Id = 2,
                     AssessmentTemplateId = 1,
                     UserId = 20000001,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                },

            };

            var mockUserData = userStatuses.AsQueryable().BuildMockDbSet();

            _mockDataContext.Setup(c => c.AssessmentUserStatus)
                .Returns(mockUserData.Object);

            //Act
            var assessmentUserStatusPersistence = new AssessmentUserStatusPersistence(_mockDataContext.Object);
            var actual = assessmentUserStatusPersistence.GetByManagerUserId(99, 20000000).Result;

            //Assert
            Assert.IsTrue(actual.Count() == 0);
        }

        [Test]
        public void GetByManagerUserId_CheckInvalidManagerIdButValidAssessmentTemplateId_ShouldReturnZeroCount()
        {
            //Arranage
            var userStatuses = new List<AssessmentUserStatus> {
                 new AssessmentUserStatus
                {
                     Id = 1,
                     AssessmentTemplateId = 1,
                     UserId = 10146063,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                }, new AssessmentUserStatus
                 {
                     Id = 2,
                     AssessmentTemplateId = 1,
                     UserId = 20000001,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                },

            };

            var mockUserData = userStatuses.AsQueryable().BuildMockDbSet();

            _mockDataContext.Setup(c => c.AssessmentUserStatus)
                .Returns(mockUserData.Object);

            //Act
            var assessmentUserStatusPersistence = new AssessmentUserStatusPersistence(_mockDataContext.Object);
            var actual = assessmentUserStatusPersistence.GetByManagerUserId(1, 123123).Result;

            //Assert
            Assert.IsTrue(actual.Count() == 0);
        }

        [Test]
        public void GetByManagerUserId_CheckInvalidManagerIdAndInvalidAssessmentTemplateId_ShouldReturnZeroCount()
        {
            //Arranage
            var userStatuses = new List<AssessmentUserStatus> {
                 new AssessmentUserStatus
                {
                     Id = 1,
                     AssessmentTemplateId = 1,
                     UserId = 10146063,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                }, new AssessmentUserStatus
                 {
                     Id = 2,
                     AssessmentTemplateId = 1,
                     UserId = 20000001,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                },

            };

            var mockUserData = userStatuses.AsQueryable().BuildMockDbSet();

            _mockDataContext.Setup(c => c.AssessmentUserStatus)
                .Returns(mockUserData.Object);

            //Act
            var assessmentUserStatusPersistence = new AssessmentUserStatusPersistence(_mockDataContext.Object);
            var actual = assessmentUserStatusPersistence.GetByManagerUserId(99, 123123).Result;

            //Assert
            Assert.IsTrue(actual.Count() == 0);
        }

        [Test]
        public void GetByManagerUserId_CheckUserThatReportsToSameManager_ShouldReturnTwo()
        {
            //Arranage
            var userStatuses = new List<AssessmentUserStatus> {
                 new AssessmentUserStatus
                {
                     Id = 1,
                     AssessmentTemplateId = 1,
                     UserId = 10146063,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                }, new AssessmentUserStatus
                 {
                     Id = 2,
                     AssessmentTemplateId = 1,
                     UserId = 20000001,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                },

            };

            var mockUserData = userStatuses.AsQueryable().BuildMockDbSet();

            _mockDataContext.Setup(c => c.AssessmentUserStatus)
                .Returns(mockUserData.Object);

            //Act
            var assessmentUserStatusPersistence = new AssessmentUserStatusPersistence(_mockDataContext.Object);
            var actual = assessmentUserStatusPersistence.GetByManagerUserId(1, 20000000).Result;

            //Assert
            Assert.IsTrue(actual.Count() == 2);
        }


        //GetRegionById Method
        [Test]
        public void GetByRegionId_CheckValidAssessmentTemplateId_ShouldReturnTrue()
        {
            //Arranage
            var userStatuses = new List<AssessmentUserStatus> {
                 new AssessmentUserStatus
                {
                     Id = 1,
                     AssessmentTemplateId = 1,
                     UserId = 10146063,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                }, new AssessmentUserStatus
                 {
                     Id = 2,
                     AssessmentTemplateId = 1,
                     UserId = 20000001,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                },

            };

            var mockUserData = userStatuses.AsQueryable().BuildMockDbSet();

            _mockDataContext.Setup(c => c.AssessmentUserStatus)
                .Returns(mockUserData.Object);

            //Act
            var assessmentUserStatusPersistence = new AssessmentUserStatusPersistence(_mockDataContext.Object);
            var actual = assessmentUserStatusPersistence.GetByRegionId(1, 1).Result.Any();

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void GetByRegionId_CheckInvalidAssessmentTemplateId_ShouldReturnFalse()
        {
            //Arranage
            var userStatuses = new List<AssessmentUserStatus> {
                 new AssessmentUserStatus
                {
                     Id = 1,
                     AssessmentTemplateId = 1,
                     UserId = 10146063,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                }, new AssessmentUserStatus
                 {
                     Id = 2,
                     AssessmentTemplateId = 1,
                     UserId = 20000001,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                },

            };

            var mockUserData = userStatuses.AsQueryable().BuildMockDbSet();

            _mockDataContext.Setup(c => c.AssessmentUserStatus)
                .Returns(mockUserData.Object);

            //Act
            var assessmentUserStatusPersistence = new AssessmentUserStatusPersistence(_mockDataContext.Object);
            var actual = assessmentUserStatusPersistence.GetByRegionId(99, 1).Result.Any();

            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void GetByRegionId_CheckValidRegionIdButInvalidAssessmentTemplateId_ShouldReturnZeroCount()
        {
            //Arranage
            var userStatuses = new List<AssessmentUserStatus> {
                 new AssessmentUserStatus
                {
                     Id = 1,
                     AssessmentTemplateId = 1,
                     UserId = 10146063,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                }, new AssessmentUserStatus
                 {
                     Id = 2,
                     AssessmentTemplateId = 1,
                     UserId = 20000001,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                },

            };

            var mockUserData = userStatuses.AsQueryable().BuildMockDbSet();

            _mockDataContext.Setup(c => c.AssessmentUserStatus)
                .Returns(mockUserData.Object);

            //Act
            var assessmentUserStatusPersistence = new AssessmentUserStatusPersistence(_mockDataContext.Object);
            var actual = assessmentUserStatusPersistence.GetByRegionId(99, 1).Result;

            //Assert
            Assert.IsTrue(actual.Count() == 0);
        }

        [Test]
        public void GetByRegionId_CheckInvalidRegionIdButValidAssessmentTemplateId_ShouldReturnZeroCount()
        {
            //Arranage
            var userStatuses = new List<AssessmentUserStatus> {
                 new AssessmentUserStatus
                {
                     Id = 1,
                     AssessmentTemplateId = 1,
                     UserId = 10146063,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                }, new AssessmentUserStatus
                 {
                     Id = 2,
                     AssessmentTemplateId = 1,
                     UserId = 20000001,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                },

            };

            var mockUserData = userStatuses.AsQueryable().BuildMockDbSet();

            _mockDataContext.Setup(c => c.AssessmentUserStatus)
                .Returns(mockUserData.Object);

            //Act
            var assessmentUserStatusPersistence = new AssessmentUserStatusPersistence(_mockDataContext.Object);
            var actual = assessmentUserStatusPersistence.GetByRegionId(1, 123123).Result;

            //Assert
            Assert.IsTrue(actual.Count() == 0);
        }

        [Test]
        public void GetByRegionId_CheckInvalidRegionIdAndInvalidAssessmentTemplateId_ShouldReturnZeroCount()
        {
            //Arranage
            var userStatuses = new List<AssessmentUserStatus> {
                 new AssessmentUserStatus
                {
                     Id = 1,
                     AssessmentTemplateId = 1,
                     UserId = 10146063,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                }, new AssessmentUserStatus
                 {
                     Id = 2,
                     AssessmentTemplateId = 1,
                     UserId = 20000001,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                },

            };

            var mockUserData = userStatuses.AsQueryable().BuildMockDbSet();

            _mockDataContext.Setup(c => c.AssessmentUserStatus)
                .Returns(mockUserData.Object);

            //Act
            var assessmentUserStatusPersistence = new AssessmentUserStatusPersistence(_mockDataContext.Object);
            var actual = assessmentUserStatusPersistence.GetByRegionId(99, 123123).Result;

            //Assert
            Assert.IsTrue(actual.Count() == 0);
        }

        [Test]
        public void GetByRegionId_CheckUserThatInSameRegion_ShouldReturnTwo()
        {
            //Arranage
            var userStatuses = new List<AssessmentUserStatus> {
                 new AssessmentUserStatus
                {
                     Id = 1,
                     AssessmentTemplateId = 1,
                     UserId = 10146063,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                }, new AssessmentUserStatus
                 {
                     Id = 2,
                     AssessmentTemplateId = 1,
                     UserId = 20000001,
                     StatusId = 0,
                     EmployeeLevelId = 1,
                     ReportsTo = 20000000,
                     UserRegionId = 1,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     ModifiedBy = 10146063,
                     IsActive = true
                },

            };

            var mockUserData = userStatuses.AsQueryable().BuildMockDbSet();

            _mockDataContext.Setup(c => c.AssessmentUserStatus)
                .Returns(mockUserData.Object);

            //Act
            var assessmentUserStatusPersistence = new AssessmentUserStatusPersistence(_mockDataContext.Object);
            var actual = assessmentUserStatusPersistence.GetByRegionId(1, 1).Result;

            //Assert
            Assert.IsTrue(actual.Count() == 2);
        }


    }
}