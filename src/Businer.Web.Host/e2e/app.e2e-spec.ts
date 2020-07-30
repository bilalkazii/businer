import { BusinerTemplatePage } from './app.po';

describe('Businer App', function() {
  let page: BusinerTemplatePage;

  beforeEach(() => {
    page = new BusinerTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
