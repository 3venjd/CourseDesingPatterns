using Factory;

SaleFactory storeSalesFactory = new StoreSaleFactory(10);
SaleFactory InternetSalesFactory = new InternetSaleFactory(2);

ISale sale1 = storeSalesFactory.GetSale();
sale1.Sell(15);

ISale sale2 = InternetSalesFactory.GetSale();
sale2.Sell(15);