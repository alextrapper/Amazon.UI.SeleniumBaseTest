﻿using Amazon.UI.PageObjects.Pages;
using NUnit.Framework;

namespace Amazon.UI.SeleniumBaseTests.Tests
{
    [TestFixture]
    public class UITests : BaseTest
    {
        [Test]
        public void BuyBluetothSpeakerTest()
        {
            // Go to amazon.com
            //Search for “Bluetooth Portable Speaker”

            new HomePage(_driver, _wait).Search.PerformSearch("Bluetooth portable speaker");

            ////In the sidebar under “customer reviews say” Check the “Good Portability”
            SearchResultsPage searchResultsPage = new SearchResultsPage(_driver, _wait);
            searchResultsPage.Filters.Departments.SelectDepartment("Portable Bluetooth Speakers");

            if (searchResultsPage.Filters.CustomersReviewsSay.IsVisible)
            {
                searchResultsPage.Filters.CustomersReviewsSay.SelectFeatureKeyword("Good Portability");
            }
            else
            {
                //In some cases Filter 'Customers Reviews Say' doesn't show
                searchResultsPage.Filters.PortableBluetothSpeakerFeatures.SelectFeatureKeyword("Ultra-Portable");
                searchResultsPage.Search.AddSentenceToSearch("OontZ");
            }
            // d.Click “OontZ Angle 3(3rd Gen)”
            ItemPage itemPage = searchResultsPage.SearchResultsList.OpenItemPage("OontZ Angle 3 (3rd Gen)");

            // e.Choose color: “blue”
            //Most popular color, like 'Blue' lead to Out-Of-Stock
            itemPage.ProductColor.SelectColor("Pink"); 

            // f.Click the “Buy Now” button
            var signInPage = itemPage.BuyBox.BuyNow();
            signInPage.AssertHeader();
        }
    }
}
