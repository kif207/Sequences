var IndexPage = function() {

    this.numberInput = element(by.model('input'));
    this.submitButton = $('button[type=\'submit\']');
    this.numberRequiredError = $('[ng-message=required]');
    this.numberPatternError = $('[ng-message=pattern]');
    this.numberValidIntegerError = $('[ng-message=ValidInteger]');
    this.allNumbers = element(by.binding('AllNumbers'));
    this.allOddNumbers = element(by.binding('AllOddNumbers'));
    this.allEvenNumbers = element(by.binding('AllEvenNumbers'));
    this.CEZSequence = element(by.binding('CEZSequence'));
    this.FibonacciNumbers = element(by.binding('FibonacciNumbers'));

    this.visit = function() {
        browser.get('/');
    };
 
    this.setNumber = function (value) {
        this.numberInput.sendKeys(value);
    };
 
    this.getSequences = function () {
        this.submitButton.click();
    };
};
module.exports = IndexPage;