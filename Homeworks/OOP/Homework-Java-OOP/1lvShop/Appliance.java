package _2.LevcheShop;

public class Appliance extends ElectronicsProduct {
// has a guarantee period of 6 months. Returns 105% of the price if the quantity is less than 50. 
	public Appliance(String name, double price, int quantity, AgeRestriction ageRestriction){
		super(name, price, quantity, ageRestriction);
		this.setGuaranteePeriod(6);
		this.isQuantityOver();
	}
	
	@Override
	protected void isQuantityOver() {
		if (this.getQuantity() < 50) {
			this.setPrice(-getPrice()/20);
		}
	}
}