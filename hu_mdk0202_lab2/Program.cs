using hu_mdk0202_lab2;

Product product1 = new Product("Продукт 1");
Product product2 = new Product("Продукт 2");
Product product3 = new Product("Продукт 3");


BOX box1 = new BOX("Коробка 1");
BOX box2 = new BOX("Коробка 2");


box1.Add(product1);
box1.Add(product2);
box2.Add(product3);


BOX mainBox = new BOX("Главная Коробка");
mainBox.Add(box1);
mainBox.Add(box2);


mainBox.Display(1);
