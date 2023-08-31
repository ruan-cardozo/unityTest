namespace Teste;

public class TestProduct
{
    [Fact]
    public void createObject()
    {
        //Arrange - Preparar cenário
        int code = 1;
        string name = "Mouse", unity = "PC";
        float balance = 0, cost = 0;

        //Act - Executar
        Product product = new Product(code, name, unity, balance, cost);


        //Assert - Esperar Resultado
        Assert.Equal(code, product.Code);
        Assert.Equal(name, product.Name);
        Assert.Equal(unity, product.Unity);
        Assert.Equal(balance, product.Balance);
        Assert.Equal(cost, product.Cost);
    }
}

public class Product
{   
        public int Code { get; }
        public string Name { get; }
        public string Unity { get; }
        public float Balance { get; }
        public float Cost { get; }

    public Produto(int code, string name, string unity, float balance, float cost)
        
    {
        Code = code;
        Name = name;
        Unity = unity;
        Balance = balance;
        Cost = cost;
    }
}
