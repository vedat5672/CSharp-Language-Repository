using System.Collections;

namespace CollectionAsserts.Tests;

[TestClass]
public class UnitTest1
{

    private List<string> users;
    [TestInitialize]
    public void CreatingData()
    {
        users = new List<string>();
        users.Add("Vedat");
        users.Add("Berfin");
        users.Add("Yunus");
        users.Add("Yusuf");

    }
    [TestMethod]
    public void TheItemsAndTheOrderIsSame()
    {
        List<string> newusers = new List<string>();
        newusers.Add("Vedat");
        newusers.Add("Berfin");
        newusers.Add("Yunus");
        newusers.Add("Yusuf");
        CollectionAssert.AreEqual(users, newusers);//sýrasý ve deðerleri ayný
        

    }
    [TestMethod]
    public void TheItemIsSameButOrderIsDiffirent()
    {
        List<string> newusers = new List<string>();
        newusers.Add("Berfin");
        newusers.Add("Vedat");
        newusers.Add("Yusuf");
        newusers.Add("Yunus");
        CollectionAssert.AreEquivalent(users, newusers); //deðerler ayný sýralar farklý
    }
    [TestMethod]
    public void TheItemsAndTheOrderIsNotSame()
    {
        List<string> newusers = new List<string>();
        newusers.Add("Vedat");
        newusers.Add("Ali");
        newusers.Add("Yunus");
        newusers.Add("Yusuf");
        CollectionAssert.AreNotEqual(users, newusers);//sýrasý ve deðerleri ayný


    }
    [TestMethod]
    public void TheItemIsNotSameButOrderIsDiffirent()
    {
        List<string> newusers = new List<string>();
        newusers.Add("Berfin");
        newusers.Add("asasa");
        newusers.Add("Yusuf");
        newusers.Add("Yunus");
        CollectionAssert.AreNotEquivalent(users, newusers); //deðerler ayný sýralar farklý
    }
    [TestMethod]
    public void AllItemsAreNotNull()
    {
        users.Add(null);
        CollectionAssert.AllItemsAreNotNull(users);
    }
    [TestMethod]
    public void AllItemsAreUniquel()
    {
        users.Add("Vedat");
        CollectionAssert.AllItemsAreUnique(users);
    }
    [TestMethod]
    public void AllItemsAreInstanceOfType()
    {
        ArrayList list = new ArrayList { "Salih", "Engin", "Ahmet" };
        CollectionAssert.AllItemsAreInstancesOfType(list, typeof(string));
    }
    [TestMethod]
    public void IsSubnetOf()
    {
        List<string>newusers=new List<string>() { "vedat","berfin"};
        List<string>oldeuser=new List<string>() { "berfin","yunus"};
        CollectionAssert.IsSubsetOf(newusers, users);
        CollectionAssert.IsSubsetOf(oldeuser, users);
    }
    [TestMethod]
    public void Contain()
    {
        CollectionAssert.Contains(users, "Berfin");
        CollectionAssert.DoesNotContain(users, "berfin");
    }
}