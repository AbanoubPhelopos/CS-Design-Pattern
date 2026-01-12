namespace AmazonOrderFulfillment.Logic.Modules;
using AmazonOrderFulfillment.Logic.Models;

public class OrderManager
{
    private readonly OrderValidator _validator;
    private readonly TaxCalculator _taxCalculator;
    private readonly PaymentProcessor _paymentProcessor;
    private readonly InvoiceGenerator _invoiceGenerator;
    private readonly EmailNotifier _emailNotifier;

    public OrderManager()
    {
        _validator = new OrderValidator();
        _taxCalculator = new TaxCalculator();
        _paymentProcessor = new PaymentProcessor();
        _invoiceGenerator = new InvoiceGenerator();
        _emailNotifier = new EmailNotifier();
    }

    public void ProcessOrder(Order order)
    {
        // 1. Validate
        if (!_validator.Validate(order)) return;

        // 2. Calculate
        decimal subTotal = order.Items.Sum(x => x.Price);
        decimal tax = _taxCalculator.CalculateTax(subTotal, order.Customer.State);
        decimal grandTotal = subTotal + tax;

        // 3. Payment
        if (_paymentProcessor.ProcessPayment(grandTotal))
        {
            // 4. Invoice
            _invoiceGenerator.GenerateInvoice(order, subTotal, tax, grandTotal);

            // 5. Notify
            _emailNotifier.SendConfirmation(order.Customer.Email);
        }
    }
}