package br.com.rdi.beans;

public class Order {

	private int id;
	private String date = new String();
	private String customer = new String();
	private double total;
	private boolean toGo;

	public Order() {}
	
	public Order(int id, String date, String customer, double total, boolean toGo) {
		this.id = id;
		this.date = date;
		this.customer = customer;
		this.total = total;
		this.toGo = toGo;
	}
	
	public String getAll() {
		return id + "\n" + date + "\n" + customer + "\n" + total + "\n" + toGo;
	}
	public void setAll(int id, String date, String customer, double total, boolean toGo) {
		this.id = id;
		this.date = date;
		this.customer = customer;
		this.total = total;
		this.toGo = toGo;
	}
	
	public int getId() {
		return id;
	}
	public String getDate() {
		return date;
	}
	public String getCustomer() {
		return customer;
	}
	public double getTotal() {
		return total;
	}
	public boolean getToGo() {
		return toGo;
	}
	public void setId(int id) {
		this.id = id;
	}
	public void setDate(String date) {
		this.date = date;
	}
	public void setCustomer(String customer) {
		this.customer = customer;
	}
	public void setTotal(double total) {
		this.total = total;
	}
	public void setToGo(boolean toGo) {
		this.toGo = toGo;
	}
}
