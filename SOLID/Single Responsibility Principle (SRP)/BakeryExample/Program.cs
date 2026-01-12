using BakeryExample;

Console.WriteLine("--- Bakery SRP Example ---");

BreadBaker baker = new BreadBaker();
InventoryManager inventoryManager = new InventoryManager();
SupplyOrder supplyOrder = new SupplyOrder();
CustomerService customerService = new CustomerService();
BakeryCleaner cleaner = new BakeryCleaner();

// Each class focuses on its specific responsibility
baker.BakeBread();
inventoryManager.ManageInventory();
supplyOrder.OrderSupplies();
customerService.ServeCustomer();
cleaner.CleanBakery();
