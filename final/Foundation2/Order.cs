using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double CalculateTotalCost()
    {
        double total = 0;

        foreach (var product in _products)
        {
            total += product.GetTotalPrice();
        }

        if (_customer.LivesInUsa())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";

        int maxIdLength = 5;  // Suponiendo que 5 es el tamaño máximo para ID.
        int maxNameLength = _products.Max(p => p.GetName().Length);  // Usa Linq para encontrar el nombre más largo.
        int maxPriceLength = 8;  // "$9999.99" es el tamaño máximo supuesto.

        foreach (var product in _products)
        {
            label += $"ID {product.GetId().ToString().PadRight(maxIdLength)} " +
                    $"{product.GetName().PadRight(maxNameLength)} " +
                    $"Unit Price {product.GetUnitPrice().ToString("$0.00").PadRight(maxPriceLength)}\n";
        }
        return label;
        // foreach (var product in _products)
        // {
        //     label += $"ID {product.GetId()} - {product.GetName()} - Unit Price ${product.GetUnitPrice():0.00} - X{product.GetQuantity()}\n";
        // }
        // return label;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().DisplayAdressInformation()}";
    }
}