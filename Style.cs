
body {
  margin: 0;
  padding: 0;
  background-color: #f0e7d2;
  color: #191817;
  font-family: Arial, sans-serif;
}

a {
  color: inherit;
  text-decoration: none;
}

h1, h2, h3 {
  font-family: Impact, sans-serif;
  text-transform: uppercase;
  letter-spacing: -2px;
}

p {
  line-height: 1.6;
}

.site-header {
  background-color: #f0e7d2;
  padding: 25px 40px;
  display: flex;
  justify-content: space-between;
  align-items: center;
  border-bottom: 3px solid #191817;
}

.logo {
  font-size: 28px;
  font-weight: bold;
}

.navigation {
  display: flex;
  gap: 25px;
}

.navigation a:hover {
  color: #d72e24;
}

.hero {
  background-color: #d72e24;
  min-height: 600px;
  padding: 80px 40px;
  position: relative;
  overflow: hidden;
  display: flex;
  align-items: center;
}

.hero-content {
  position: relative;
  z-index: 2;
  max-width: 700px;
}

.hero h1 {
  color: #f0e7d2;
  font-size: 100px;
  margin-bottom: 25px;
}

.hero p {
  font-size: 18px;
  margin-bottom: 25px;
  max-width: 400px;
}

.button {
  display: inline-block;
  background-color: #191817;
  color: #f0e7d2;
  padding: 15px 25px;
  margin-top: 10px;
}

.button:hover {
  background-color: #f2bd35;
  color: #191817;
}

.shape {
  position: absolute;
}

.shape-circle {
  background-color: #f2bd35;
  width: 250px;
  height: 250px;
  border-radius: 50%;
  right: 50px;
  top: 50px;
}

.shape-triangle {
  width: 0;
  height: 0;
  border-left: 100px solid transparent;
  border-right: 100px solid transparent;
  border-bottom: 300px solid #191817;
  right: 150px;
  bottom: -50px;
  transform: rotate(20deg);
}

.shape-block {
  background-color: #244e75;
  width: 100px;
  height: 250px;
  position: absolute;
  right: 300px;
  top: 200px;
  transform: rotate(-20deg);
}

.shape-slash {
  background-color: #f0e7d2;
  width: 15px;
  height: 600px;
  position: absolute;
  right: 350px;
  top: 0;
  transform: rotate(25deg);
}

.intro {
  padding: 80px 40px;
  border-bottom: 3px solid #191817;
}

.intro h2 {
  font-size: 65px;
  margin-bottom: 35px;
}

.intro-grid {
  display: grid;
  grid-template-columns: 2fr 1fr;
  gap: 40px;
}

.intro-aside {
  background-color: #f2bd35;
  padding: 25px;
  border: 3px solid #191817;
}

.features {
  background-color: #244e75;
  color: #f0e7d2;
  padding: 80px 40px;
}

.section-heading h2 {
  font-size: 65px;
  margin-bottom: 25px;
}

.section-heading p {
  margin-bottom: 40px;
}

.feature-grid {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  gap: 20px;
}

.feature-card {
  background-color: #f0e7d2;
  color: #191817;
  border: 3px solid #191817;
}

.card-art {
  height: 220px;
  background-color: #d72e24;
  border-bottom: 3px solid #191817;
}

.card-copy {
  padding: 20px;
}

.card-copy h3 {
  font-size: 30px;
  margin-bottom: 15px;
}

.card-red .card-art {
  background-color: #d72e24;
}

.card-yellow .card-art {
  background-color: #f2bd35;
}

.card-blue .card-art {
  background-color: #244e75;
}

.statement {
  background-color: #f2bd35;
  padding: 100px 40px;
  position: relative;
  overflow: hidden;
  border-bottom: 3px solid #191817;
}

.statement h2 {
  font-size: 80px;
  max-width: 800px;
  margin-bottom: 25px;
  position: relative;
  z-index: 2;
}

.statement p {
  max-width: 400px;
  position: relative;
  z-index: 2;
}

.statement-shape {
  background-color: #d72e24;
  width: 200px;
  height: 500px;
  position: absolute;
  right: 100px;
  top: -50px;
  transform: rotate(30deg);
}

.about {
  padding: 80px 40px;
  display: grid;
  grid-template-columns: 1fr 1fr;
  gap: 50px;
  align-items: center;
  border-bottom: 3px solid #191817;
}

.about-graphic {
  background-color: #d72e24;
  height: 350px;
  border: 3px solid #191817;
}

.about-content h2 {
  font-size: 60px;
  margin-bottom: 25px;
}

.text-link {
  display: inline-block;
  margin-top: 25px;
  border-bottom: 3px solid #d72e24;
  padding-bottom: 5px;
}

.site-footer {
  background-color: #191817;
  color: #f0e7d2;
  padding: 40px;
  display: flex;
  justify-content: space-between;
  align-items: center;
}

.footer-mark {
  font-size: 25px;
  font-weight: bold;
}

.footer-info {
  font-size: 14px;
}
