class CallService {
  constructor() {
    this.calls = [];
    this.Counter = 0;
  }

  addCall() {
    const name = "NewCall " + (++this.Counter);
    const operation = "";
    const templatePath = "";
    this.calls.push({
      name: name,
      operation: operation,
      templatePath: templatePath
    });
  }

  deleteCall(call) {
    this.calls = this.calls.filter(callInService => callInService.data == call.data);
    return this.calls;
  }

  getCalls() {
    return this.calls.map(c => ({
      label: c.name, data: c, children: [
        { label: "Name: " + c.name },
        { label: "Operation:" + c.operation },
        { label: "Template path:" + c.templatePath },
      ]
    }));
  }
}

export default new CallService();
