using DesingPatternConsole.FactoryPattern;

SaleFactory storeSaleFactory = new StoreSaleFactory(10);
SaleFactory internetSaleFactory = new InternetSaleFactory(2);

ISale sale1 = storeSaleFactory.GetSale();
sale1.Sell(15);

ISale sale2 = internetSaleFactory.GetSale();
sale2.Sell(15);

