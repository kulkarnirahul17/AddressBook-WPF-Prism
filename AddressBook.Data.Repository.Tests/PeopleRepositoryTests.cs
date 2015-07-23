using AddressBook.Entities;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AddressBook.Data.Repository.Tests
{
	[TestClass]
	public class PeopleRepositoryTests
	{
		private IPeopleRepository repository;

		[TestMethod]
		public void Can_Add_New_person_And_Get_ID()
		{
			repository.Add(new Person() { FirstName = "Rahul", LastName = "Kulkarni", MiddleInitial = "R" });
			repository.SaveChanges();
		}

		[TestMethod]
		public void Can_Get_Instance_Of_Repository()
		{
			Assert.IsNotNull(repository);
		}

		[TestMethod]
		public void Get_By_Id_Returns_The_Element_If_It_Exists()
		{
			var person = new Person()
			{
				FirstName = "Rahul",
				LastName = "Kulkarni",
				MiddleInitial = "R"
			};
			repository.Add(person);
			repository.SaveChanges();
			
			var item = repository.GetByID(person.ID);
			Assert.IsNotNull(item);
		}

		[TestMethod]
		public void GetAll_Returns_A_List_With_Non_Zero_Count()
		{
			var personList = repository.GetAll().ToList();
			Assert.IsNotNull(personList);
		}

		[TestInitialize]
		public void Initialize()
		{
			IUnityContainer container = new UnityContainer();
			container.LoadConfiguration();
			repository = container.Resolve<IPeopleRepository>();
		}
	}
}