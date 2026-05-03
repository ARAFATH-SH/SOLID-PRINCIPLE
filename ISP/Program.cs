using System;
using ISP;

OrderService order = new OrderService();
order.createOrder("Arafath", "Ipad", 45000, 1, "bkash");
order.refundOrder("Arafath", 45000, "bkash");
order.setUpAutoPayment("Arafath", 45000, "tx924nw", "bkash");
order.setUpAutoPayment("Shihab", 45000, "yrb20483", "nagad");