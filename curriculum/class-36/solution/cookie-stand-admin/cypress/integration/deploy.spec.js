context('Deploy', () => {
    beforeEach(() => {
        cy.visit('http://localhost:3000');
    });

    it('should have correct h1', () => {
        cy.get('h1').should('have.text', 'Cookie Stand Admin');
    })

    it('should have correct footer', () => {
        cy.get('footer').should('have.text', '©2021');
    });

    it('should have correct number of inputs', () => {
        cy.get('input').should('have.length', 4);
    });

    it('should properly fill out form', () => {

        const info = {
            location: "Barcelona",
            minCustomers: 5,
            maxCustomers: 10,
            avgCookies: 2.5
        }

        cy.get('input').eq(0).type(info.location);
        cy.get('input').eq(1).type(info.minCustomers);
        cy.get('input').eq(2).type(info.maxCustomers);
        cy.get('input').eq(3).type(info.avgCookies);
        cy.get('form').submit();
        cy.get('pre>code').should('have.text', JSON.stringify(info));

    });

    it('should require all inputs', () => {
        cy.get('form').submit();
        cy.get('input:invalid').should('have.length', 4)
    });
});
