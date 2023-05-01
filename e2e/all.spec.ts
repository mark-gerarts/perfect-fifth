import { test } from '@playwright/test';

let referenceSketches = require('child_process')
    .execSync(`find gh-pages/output/reference* -type f -printf "%f\n"`)
    .toString()
    .split(`\n`);


test.describe.configure({ mode: 'parallel' });

for (const sketch of referenceSketches) {
    test(`reference sketch ${sketch} should not have errors`, async ({ page }) => {
        page.on('pageerror', _ => {
            throw new Error(`Page ${sketch} contains errors`);
        });
        await page.goto(`http://localhost:8000/${sketch}`);

        // As far as I can find, there is no reliable way to know if a P5
        // sketch is running. Until we do find a way, simply wait for a
        // second to check for any errors.
        await page.waitForTimeout(1000);
    });
}
