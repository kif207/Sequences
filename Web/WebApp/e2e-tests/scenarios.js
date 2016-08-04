var IndexPage = require('./index-page');

describe('Numeric Sequence Calculator', function () {
    
    beforeEach(function(){
	    browser.get('/');
	});

    it('should display an error message if the number field is empty', function () {
	    var page = new IndexPage();
		page.setNumber('');
	    page.getSequences();
	    expect(page.numberRequiredError.isDisplayed()).toBe(true);
	});

	it('should display an error message if the entered number has a negative value', function () {
	    var page = new IndexPage();	    
	    page.setNumber('-1');
	    page.getSequences();
	    expect(page.numberPatternError.isDisplayed()).toBe(true);
	});

	it('should display an error message if the entered number is not a numeric value', function () {
	    var page = new IndexPage();
	    page.setNumber('1a');
	    page.getSequences();
	    expect(page.numberPatternError.isDisplayed()).toBe(true);
	});

	it('should display an error message if the entered number is greater than 2147483646', function () {
	    var page = new IndexPage();
	    page.setNumber('2147483647');
	    page.getSequences();
	    expect(page.numberValidIntegerError.isDisplayed()).toBe(true);
	});

	it('should display an All Numbers sequence for a valid number', function () {
	    var page = new IndexPage();
	    page.setNumber('5');
	    page.getSequences();
	    expect(page.allNumbers.getText()).toBe('0,1,2,3,4,5');
	});

	it('should display an All Odd Numbers sequence for a valid number', function () {
	    var page = new IndexPage();
	    page.setNumber('10');
	    page.getSequences();
	    expect(page.allOddNumbers.getText()).toBe('1,3,5,7,9');
	});

	it('should display an All Even Numbers sequence for a valid number', function () {
	    var page = new IndexPage();
	    page.setNumber('10');
	    page.getSequences();
	    expect(page.allEvenNumbers.getText()).toBe('0,2,4,6,8,10');
	});

	it('should display an CEZ sequence for a valid number', function () {
	    var page = new IndexPage();
	    page.setNumber('16');
	    page.getSequences();
	    expect(page.CEZSequence.getText()).toBe('0,1,2,C,4,E,C,7,8,C,E,11,C,13,14,Z,16');
	});

	it('should display an fibonacci numbers sequence for a valid number', function () {
	    var page = new IndexPage();
	    page.setNumber('14');
	    page.getSequences();
	    expect(page.FibonacciNumbers.getText()).toBe('0,1,1,2,3,5,8,13');
	});
});