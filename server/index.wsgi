import sae
from server import app

application = sae.create_wsgi_app(app)
