package _2.LevcheShop;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.concurrent.TimeUnit;

public class FoodProduct extends Product implements Expirable {

	public Date expirationDate;
	
	public FoodProduct(String name, double price, int quantity, 
			AgeRestriction ageRestriction, String expirationDate) throws ParseException{
		super(name, price, quantity, ageRestriction);
		this.setExpirationDate(expirationDate);
		isExpirated();
	}
	
	public void setExpirationDate(String expirationDate) throws ParseException {
		String target = expirationDate;
		DateFormat formatter = new SimpleDateFormat("dd-MM-yyyy");
		Date date = formatter.parse(target);
		this.expirationDate = date;
	}
	
	@Override
	public Date getExpirationDate() {
		return this.expirationDate;
	}

	public boolean isExpirated(){
		long now = new Date().getTime();
		long period = (this.getExpirationDate().getTime() - now);
		int days = (int) TimeUnit.DAYS.convert(period, TimeUnit.MILLISECONDS);
		if (days < 15) {
			this.setPrice(this.getPrice()*0.7);
			return true;
		}
		return false;
	}
}