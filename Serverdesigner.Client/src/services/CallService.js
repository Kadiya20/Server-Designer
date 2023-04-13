class CallService {
  constructor() {
    this.calls = [];
    this.counter = 0;
  }

  addCall() {
    const name = "NewCall " + (++this.counter);
    const operation = "";
    const templatePath = "";
    this.calls.push({
      name: name,
      operation: operation,
      templatePath: templatePath,
    });
  }

  deleteCall(call) {
    console.log(call);
    this.calls = this.calls.filter(c => c.name !== call.name);
  }

  cloneCall(call) {
    const clonedCall = {
      name: call.name.replace(/^(NewCall \d+)/, '$1 Clone'),
      operation: call.operation,
      templatePath: call.templatePath,
    };
    this.calls.push(clonedCall);
  }

  addInputParameter(call, inputparameter) {
    const found = this.calls.find(c => c.name === call.name);
    if (!found) { return false; }
    if (found.inputParameters) {
      // input parameters already exist for the call
      return false;
    } else {
      found.inputParameters = [];
      found.inputParameters.push({ inputparameter }); 
      return true;
    }
  }

  getCalls() {
    return this.calls.map(c => {
      const children = [
        { label: "Name: " + c.name },
        { label: "Operation: " + c.operation },
        { label: "Template path: " + c.templatePath },
      ];
      if (c.inputParameters) {
        children.push({ label: "Input Parameters" });
      }
      return { label: c.name, data: c, children };
    });
  }
}

export default new CallService();