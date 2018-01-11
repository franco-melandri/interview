
const sut = require('./index');

describe('Jest test', () => {

    test("hello world", () => {
        expect(sut('number')).toBe('hello world');
    });

});