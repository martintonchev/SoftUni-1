package _2.LevcheShop;

public abstract class Product implements Buyable {

	//holds name, price, quantity and age restriction (can be None, Teenager or Adult). 
	private String name;
	private double price;
	private int quantity;
	private AgeRestriction ageRestriction;
	
	public Product(String name, double price, int quantity, AgeRestriction ageRestriction){
		this.setName(name);
		this.setPrice(price);
		this.setQuantity(quantity);
		this.setAgeRestriction(ageRestriction);
	}
	
	public String getName() {
		return this.name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public void setPrice(double price) {
		this.price = price;
	}

	public double getPrice() {
		return this.price;
	}

	public int getQuantity() {
		return this.quantity;
	}

	public void setQuantity(int quantity) {
		this.quantity = quantity;
	}

	public AgeRestriction getAgeRestriction() {
		return this.ageRestriction;
	}

	public void setAgeRestriction(AgeRestriction ageRestriction) {
		this.ageRestriction = ageRestriction;
	}

	@Override
	public String toString(){
		return "Type: " + this.getClass() + 
				". Name: " + this.getName() +
				". Price: " + this.getPrice() +
				". Quantity: " + this.getQuantity() +
				". Age restriction: " + this.getAgeRestriction();
	}
}