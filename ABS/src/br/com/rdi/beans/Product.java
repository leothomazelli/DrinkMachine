package br.com.rdi.beans;

public class Product {
	
	private String name = new String();
	private String cup = new String();
	private String lid = new String();
	private double ice;
	private String size;
	
	public Product() {}
	
	public Product(String name, String cup, String lid, double ice, String size) {
		this.name = name;
		this.cup = cup;
		this.lid = lid;
		this.ice = ice;
		this.size = size;
	}
	
	public String getAll() {
		return name + "\n" + cup + "\n" + lid + "\n" + ice + "\n" + size;
	}
	public void setAll(String name, String cup, String lid, double ice, String size) {
		this.name = name;
		this.cup = cup;
		this.lid = lid;
		this.ice = ice;
		this.size = size;
	}
	
	public String getName() {
		return name;
	}
	public String getCup() {
		return cup;
	}
	public String getLid() {
		return lid;
	}
	public double getIce() {
		return ice;
	}
	public String getSize() {
		return size;
	}
	public void setName(String name) {
		this.name = name;
	}
	public void setCup(String cup) {
		this.cup = cup;
	}
	public void setLid(String lid) {
		this.lid = lid;
	}
	public void setIce(double ice) {
		this.ice = ice;
	}
	public void setSize(String size) {
		this.size = size;
	}
}
