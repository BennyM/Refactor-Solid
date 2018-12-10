# Single responsibility principle

You've been assigned this code base and will perform maintenance and implement future features. As a first step you try to find all the responsibilities and create distinct classes for them.

You also need to support online orders. When someone orders products online, the credit card needs to be charged, an inventory lookup needs to take place and a notification needs to be send. When someone visits the store, we don't need to send out a notification or perform an inventory check. Physical orders can be payed with a credit card and with cash.