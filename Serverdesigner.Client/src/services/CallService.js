class CallService {
    constructor() {
      this.calls = [];
    }

    addCall(name) {
        this.calls.push({label: name, data: {name: name}});
    }

    getCalls() {
        return [...this.calls]
    }
  }

export default new CallService();
