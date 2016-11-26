# AzureNotebookGateway

### Gateway to allow passing arbitrary files to Azure Notebooks

Unfortunately, [Azure Notebooks](http://notebooks.azure.com) limit access to external data from a few sources. This gateway
allows your Azure notebooks to download data (in particular, images) from any place on the internet.

To use it:

  * Deploy the project somewhere on Azure (eg. http://az.azurewebsites.net)
  * In your notebook, substitute URLs like http://image.net/image.jpg to http://az.azurewebsites.net/api/gateway?q=https%3A%2F%2Fimages.net%2Fimage.jpg
  * Enjoy!

