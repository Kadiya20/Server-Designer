class Call {
    constructor() {
        this.id = null;
        this.actions = [];
        this.serviceUrl = '';
        this.templatePath = '';
        this.azlogin = null;
        this._inputParameters = [];
        this.serviceHeader = null;
        this.operation;
        this.image;

        this.name = '';
    }

    get Id() {
        return this.id;
    }

    set Id(value) {
        this.id = value;
    }

    get Name() {
        return this.name;
    }

    set Name(value) {
        this.name = value;
    }

    get TemplatePath() {
        return this.templatePath;
    }

    set TemplatePath(value) {
        this.templatePath = value;
    }

    get ServiceUrl() {
        return this.serviceUrl;
    }

    set ServiceUrl(value) {
        this.serviceUrl = value;
    }

    get ImagePath() {
        return this.image;
    }

    set ImagePath(value) {
        this.image = value;
    }

    get InputParameters() {
        return this._inputParameters;
    }

    set InputParameters(value) {
        this._inputParameters = value;
    }

    get Operation() {
        return ['GenerateDocument', 'GenerateSpreadSheets', 'GenerateSlides'];
    }

    set Operation(value) {
        this.operation = value;
    }

    get SelectedOperation() {
        return this.operation;
    }

    set SelectedOperation(value) {
        this.operation = value;
    }

    get Actions() {
        return this.actions;
    }

    set Actions(value) {
        this.actions = value;
    }

    get Azlogin() {
        return this.azlogin;
    }

    set Azlogin(value) {
        this.azlogin = value;
    }

    get ServiceHeader() {
        return this.serviceHeader;
    }

    set ServiceHeader(value) {
        this.serviceHeader = value;
    }

    SaveDictionaryToInputParameter(dicToSave) {
        for (const [key, val] of Object.entries(dicToSave)) {
            const existingParam = this.InputParameters.find(p => p.Key.toLowerCase() === key.toLowerCase());
            if (!existingParam) {
                this.InputParameters.push({ Key: key, Value: val });
            } else {
                existingParam.Value = val;
            }
        }
    }

    InputParametersToDic() {
        const result = {};
        this.InputParameters.forEach(p => result[p.Key] = p.Value);
        return result;
    }

    SelectedField() {
        this.SelectedOperation = this.Operation[0];
    }

    GetImageUrl() {
        return 'Images/icon.png';
    }

    GetTitle() {
        return 'New Call';
    }

    GetPropertyTitle(title) {
        const r = /(?<=[A-Z])(?=[A-Z][a-z])|(?<=[^A-Z])(?=[A-Z])|(?<=[A-Za-z])(?=[^A-Za-z])/g;
        if (title.includes('.')) {
            title = title.substring(title.indexOf('.') + 1);
        }
        return title.replace(r, ' ');
    }

    GetPropertyImageUrl() {
        return 'Images/paramicon.png';
    }
}
