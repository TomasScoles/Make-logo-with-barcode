const Symbology = require("symbology");
const SymbologyType = Symbology.SymbologyType;
const fs = require("fs");

fs.readFile("setting.ini", (err, text) => {
  const strs = text.toString().split(/\r?\n/);

  (async () => {
    const { data } = await Symbology.createFile(
      {
        symbology:
          strs[0] == "q" ? SymbologyType.QRCODE : SymbologyType.CODE128,
        fileName: "./barcodes//" + strs[1],
        showHumanReadableText: false,
        whitespaceWidth: 2,
      },
      strs[2]
    );
  })();
});
