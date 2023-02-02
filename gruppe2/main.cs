using System;

public class Owner {
}

public class Customer {

}

public class Bar {

}


public class Pub {
    private Owner owner;
    private Customer[] customers;
    private Bar bar;

    public Pub(Customer[] customers) {
        this.owner = new Owner();
        this.customers = customers;
        this.bar = new Bar();

    }

}

