package _2.LevcheShop;

import java.text.ParseException;
import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;

public class _DemoShop {

	public static void main(String[] args) throws ParseException {		

		FoodProduct cigars = new FoodProduct("420 Blaze it fgt", 6.90, 1400, AgeRestriction.ADULT, "29-11-2014");
		Customer pecata = new Customer("Pecata", 17, 30.00);
		Customer gopeto = new Customer("Gopeto", 18, 0.44);
		System.out.println(pecata.getBalance());
		System.out.println(cigars.getQuantity());
		
		PurchaseManager.ProcessPurchase(pecata, cigars);
		PurchaseManager.ProcessPurchase(gopeto, cigars);		
				
		System.out.println(pecata.getBalance());
		System.out.println(cigars.getQuantity());
		
		
		PurchaseManager.ProcessPurchase(gopeto, cigars);
		
		List<Product> products = new ArrayList<Product>();
		
		products.add(new FoodProduct("Toothpaste Aquafresh", 5.00, 10, AgeRestriction.NONE, "2016-05-07"));
		products.add(new FoodProduct("Vita bread", 1.10, 2, AgeRestriction.ADULT, "2014-10-20"));
		products.add(new FoodProduct("7Days", 0.79, 111, AgeRestriction.TEENAGER, "2014-05-12"));
		products.add(new Computer("ExtraDelux XF 11", 699.90, 20, AgeRestriction.NONE));
		products.add(new Computer("TheBesto", 1699.90, 2, AgeRestriction.ADULT));
		products.add(new Appliance("Eldom Oven", 299.90, 60, AgeRestriction.NONE));
		
		Comparator<Product> byDateOfExpiry = (p1, p2) -> 
		(((FoodProduct) p1).getExpirationDate().after(((FoodProduct) p2).getExpirationDate())?-1:
		 ((FoodProduct) p1).getExpirationDate().after(((FoodProduct) p2).getExpirationDate())?1:0);
		Comparator<Product> byPrice = (p1, p2) -> Double.compare(p1.getPrice(), (p2.getPrice()));
		
		Product expirableProduct = products.stream()
				.filter(p -> p instanceof Expirable)
				.sorted(byDateOfExpiry)
				.findFirst()
				.get();
		
		System.out.println(expirableProduct);
		System.out.println("\n ----------------");
		
		List<Product> adultAgerestrictionByPrice = products.stream()
				.filter(p -> p.getAgeRestriction() == AgeRestriction.ADULT)
				.sorted(byPrice)
				.collect(Collectors.toList());
		
		for (Product product : adultAgerestrictionByPrice) {
			System.out.println(product + "\n");
		}
	}

}