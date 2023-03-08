class CallService {
    constructor() {
      this.calls = [];
      this.counter= 1;
    }

    addCall() {
      const callName = `NewCall ${this.counter}`;
      const call = {
        label: callName,
        data: {
            name: callName,
            operation: operation,
            templatePath: templatePath
        }
    };
      this.calls.push(call);
      this.callCounter++;
 
    }
  
    getCalls() {
        return [...this.calls]
    }
  }

export default new CallService();
