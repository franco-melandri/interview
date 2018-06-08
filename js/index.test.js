
const sut = require('./index');

describe('Jest test', () => {

    test("hello world", () => {
        expect(sut(0)).toBe('hello world');
    });
});