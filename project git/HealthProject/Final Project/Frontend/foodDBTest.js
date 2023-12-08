class Food {
	constructor(name, calories, fat, protein, carbs, quantity){
		this.name = name;
		this.calories = calories;
		this.fat = fat;
		this.protein = protein;
		this.carbs = carbs;
		this.quantity = quantity;
	}

}


const whiteBread = new Food("White Bread", 67, 1, 2, 13, "Slice");

const brownBread = new Food("Brown Bread", 74, 0.7, 2.9, 15.1, "Slice");

const chicken = new Food("Chicken", 165, 3.6, 31, 0, "100g");

const apple = new Food("Apple", 95, 0, 1, 25, "One");

const banana = new Food("Banana", 110, 0, 1, 28, "One");

const wholeMilk = new Food("Whole Milk", 31, 1.68, 2.71, 2.33, "50ml");

const skimMilk = new Food("Skimmed Milk", 18, 0.09, 1.78, 2.53, "50ml");

const chedCheese = new Food("Cheddar Cheese", 114, 9.5, 6.5, 0.96, "50g");

describe('Food tests', () => {
    test('Banana Propertis', () => {
        expect(banana.name).toBe('Banana');
        expect(banana.protein).toBe(1);
    });

    test('Skim Milk per 50ml attributes', () => {
        expect(skimMilk.calories).toBe(18);
        expect(skimMilk.carbs).toBe(2.53);
        expect(skimMilk.quantity).toBe('50ml');
    });

});