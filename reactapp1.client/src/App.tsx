import './App.css';

function App() {
    // logic: standard TypeScript variables
    const jobTitle = "Junior Software Developer"; // Example variable
    const currentDate = new Date().toLocaleDateString();  // Get current date

    function handleLogin() {

        alert("Login clicked! Connecting to server");
    }
    // the view ( UI )
    return (
        <div className="app-container">
            <h1>Login  as  {jobTitle}!</h1>
            <p>Today is: {currentDate}</p>

            <button className="login-btn" onClick={handleLogin}>
                Log In
            </button>

        </div>
    );
}

export default App;