package _2.LevcheShop;

public abstract class ElectronicsProduct extends Product {

	private int guaranteePeriod;
	
	public ElectronicsProduct(String name, double price, int quantity, AgeRestriction ageRestriction){
		super(name, price, quantity, ageRestriction);
	}

	public int getGuaranteePeriod() {
		return this.guaranteePeriod;
	}

	public void setGuaranteePeriod(int guaranteePeriod) {
		this.guaranteePeriod = guaranteePeriod;
	}
	
	protected abstract void isQuantityOver();
}