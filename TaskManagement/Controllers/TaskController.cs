using Microsoft.AspNetCore.Mvc;

namespace TaskManagement.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{

    [HttpGet(Name = "GetTask")]
    public List<Task> Get()
    {
        var myContext = new MyContext();
        return myContext.Tasks.ToList();
    }

    public Boolean Post()
    {
        var myContext = new MyContext();
        myContext.Tasks.ToList();


        string _productTitle = productTitle.Text;


        int _productPrice, _productCount;

        if (Int32.TryParse(productPrice.Text, out _productPrice) && Int32.TryParse(productCount.Text, out _productCount))
        {
            Product product = new Product();

            product.Title = _productTitle;
            product.Price = _productPrice;
            product.Count = _productCount;

            var dbContext = new miniprojectContext();

            string messageBoxText;

            if (productId != 0)
            {
                product.Id = productId;
                dbContext.Products.Update(product);
                messageBoxText = "Product updated succesfully!";
            }
            else
            {
                dbContext.Products.Add(product);
                messageBoxText = "Product added succesfully!";

            }

            dbContext.SaveChanges();

            string caption = "Done";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;

            MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);

            this.Close();


        }
        else
        {
            string messageBoxText = "Please check entered values!";
            string caption = "Error";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Error;
            MessageBoxResult result;

            result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);

        }





        return true;
    }
}

