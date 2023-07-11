const main = require("../src/main");

describe("main should", () => {
    it("fail", () => {
        expect(main()).toBe(true);
    });
});