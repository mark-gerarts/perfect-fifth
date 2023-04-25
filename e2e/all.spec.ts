import { test, chromium } from '@playwright/test';

const checkLinksOnPage = async (browser, page) => {
    const hrefs = await page.evaluate(() => {
        return Array.from(document.links)
            .map(item => item.href)
            .filter(href => href.match(/.*-.*\.html/));
    });

    const batchSize = 5;
    for (let i = 0; i < hrefs.length; i += batchSize) {
        const batch = hrefs.slice(i, i + batchSize);

        await Promise.all(batch.map(async href => {
            console.log(`Checking ${href}...`);
            const referencePage = await browser.newPage();
            referencePage.on('pageerror', _ => {
                throw new Error(`Page ${href} contains errors`);
            });
            await referencePage.goto(href);

            // As far as I can find, there is no reliable way to know if a P5
            // sketch is running. Until we do find a way, simply wait for a
            // second to check for any errors.
            await referencePage.waitForTimeout(1000);
        }));
    }
}

test('reference sketches should not have errors', async ({ page }) => {
    const browser = await chromium.launch();
    await page.goto('http://localhost:8000/reference.html');
    await checkLinksOnPage(browser, page);
});

test('example sketches should not have errors', async ({ page }) => {
    const browser = await chromium.launch();
    await page.goto('http://localhost:8000/examples.html');
    await checkLinksOnPage(browser, page);
});
