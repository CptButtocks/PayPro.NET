using PayPro.NET;
using PayPro.NET.Model;

PayProClient client = new("60b928170181259e8454abfa6ff55c1c");

CreatePaymentResponse response = await client.Payments.CreatePayment(new CreatePaymentRequest(1000, "test@customer.nl")
{
    TestMode = true,
});

Console.WriteLine("Created a test payment");
