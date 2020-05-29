using GIFTRETEPROJECT.PageObject;
using System;
using TechTalk.SpecFlow;

namespace GIFTRETEPROJECT.StepDefinition
{
    [Binding]
    public class PostItemSteps
    {
        PostItemPage postitempage;
        public PostItemSteps()
        {
            postitempage = new PostItemPage();
        }

        [When(@"I click on postitem")]
        public void WhenIClickOnPostitem()
        {
            postitempage.ClickPostItem(); 
        }

        [When(@"I enter itemname")]
        public void WhenIEnterItemname()
        {
            postitempage.EnterItemName();
        }

        [When(@"I enter itemdescription")]
        public void WhenIEnterItemdescription()
        {
            postitempage.EnterItemDescription();
        }

        [When(@"I select itemcategory")]
        public void WhenISelectItemcategory()
        {
            postitempage.SelectItemCategory();
        }

        [When(@"I select itemtype")]
        public void WhenISelectItemtype()
        {
            postitempage.SelectItemType();
        }

        [When(@"I enter itemweight")]
        public void WhenIEnterItemweight()
        {
            postitempage.EnterItemWeight();
        }

        [When(@"I enter itemlocation")]
        public void WhenIEnterItemlocation()
        {
            postitempage.EnterItemLocation();
        }

        [When(@"I choose a itemimage")]
        public void WhenIChooseAItemimage()
        {
            postitempage.ChooseItemImage();
        }
        
        [When(@"I click on add")]
        public void WhenIClickOnAdd()
        {
            postitempage.ClickOnAdd();
        }
        
        [Then(@"An item should be posted")]
        public void ThenAnItemShouldBePosted()
        {
           
        }
    }
}
